using System.Text.RegularExpressions;

namespace OfficeReportForm
{
    public partial class Form1 : Form
    {
        private readonly List<Person> PersonList = new();
        private readonly static String INVALID_NAME = "Entered name is invalid, cannot contain numbers, spaces, punctuation.";
        private readonly static String INVALID_OFFICE = "Entered office # invalid, cannot contain spaces.";
        private readonly static String INVALID_TELEPHONE = "Entered telephone # invalid, must be in the format 000-000-0000.";

        public Form1() { InitializeComponent(); }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            OutputListView.View = View.Details;
            OutputListView.Columns.Add("Name");
            OutputListView.Columns.Add("Office #");
            OutputListView.Columns.Add("Telephone #");

            if (InputFileDialog.ShowDialog() != DialogResult.OK)
                Application.Exit();

            OutputListView.HeaderStyle = ColumnHeaderStyle.None;
        }

        private void Form1_FormClosing(object sender, EventArgs e){ WriteFile(); }

        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            if (radio != null && radio.Checked)
            {
                OutputListView.Items.Clear();
                OutputListView.HeaderStyle = ColumnHeaderStyle.Clickable;
            }
            
            if (radioPrintList.Checked) PrintList();
            else if (radioAddEntry.Checked) AddEntry();
            else if (radioSearchName.Checked)
            {
                string name = NameTextBox.Text.Trim(' ');

                if (!IsValidName(name))
                {
                    OutputListView.HeaderStyle = ColumnHeaderStyle.None;
                    OutputListView.Items.Add(INVALID_NAME);
                }
                else if (SearchName(name) != -1)
                {
                    Person foundPerson = PersonList[SearchName(name)];
                    var item = new ListViewItem(new[] { foundPerson.Name, foundPerson.Office, foundPerson.Telephone });
                    OutputListView.Items.Add(item);
                }
                else
                {
                    OutputListView.HeaderStyle = ColumnHeaderStyle.None;
                    OutputListView.Items.Add("Entry with entered name not found");
                }
            }
            else if (radioSearchOffice.Checked) SearchOffice();
            else if (radioSearchTelephone.Checked) SearchTelephone();
            else if (radioChangeOffice.Checked) ChangeOffice();
            else if (radioSortList.Checked)
            {
                PersonList.Sort();
                OutputListView.HeaderStyle = ColumnHeaderStyle.None;
                OutputListView.Items.Add("List successfully sorted by name.");
            }
            else if (radioRemoveEntry.Checked) RemoveEntry();

            if (radio != null && radio.Checked)
            {
                radio.Checked = false;
                OutputListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                OutputListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                NameTextBox.Clear();
                OfficeTextBox.Clear();
                TelephoneTextBox.Clear();
            }
        }

        private void InputFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e) 
        {
            PersonList.Clear();

            string fileName = InputFileDialog.FileName;
            using StreamReader inFile = new(fileName);
            string? line = inFile.ReadLine();
            while (line != null)
            {
                line = line.Trim();
                string[] tok = Regex.Split(line, @"\s+");

                if (tok.Length == 3 && IsValidName(tok[0]) && IsValidOffice(tok[1]) && IsValidTelephone(tok[2]) && SearchName(tok[0]) == -1)
                    PersonList.Add(new Person(tok[0], tok[1], tok[2]));

                line = inFile.ReadLine();
            }

            OutputListView.Items.Add("Successfully read " + PersonList.Count + " from the data file.");
            OutputListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            OutputListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void OutputListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = OutputListView.Columns[e.ColumnIndex].Width;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputListView.HeaderStyle = ColumnHeaderStyle.None;
            OutputListView.Items.Clear();

            NameTextBox.Clear();
            OfficeTextBox.Clear();
            TelephoneTextBox.Clear();
        }

        private void ChangeFileButton_Click(object sender, EventArgs e)
        {
            WriteFile();
            ClearButton_Click(sender, e);
            InputFileDialog.ShowDialog();
        }

        private void PrintList()
        {
            foreach (Person person in PersonList)
            {
                var item = new ListViewItem(new[] {person.Name, person.Office, person.Telephone});
                OutputListView.Items.Add(item);
            }
        }

        private int SearchName(string name)
        {
            for(int i = 0; i < PersonList.Count; i++)
            {
                if(PersonList[i].Name == name)
                    return i;
            }

            return -1;
        }

        private void SearchOffice()
        {
            string office = OfficeTextBox.Text.Trim(' ');
            if(!IsValidOffice(office))
            {
                OutputListView.HeaderStyle = ColumnHeaderStyle.None;
                OutputListView.Items.Add(INVALID_OFFICE);
                return;
            }

            foreach(Person person in PersonList)
            {
                if(person.Office == office)
                {
                    var item = new ListViewItem(new[] { person.Name, person.Office, person.Telephone });
                    OutputListView.Items.Add(item);
                }
            }

            if(OutputListView.Items.Count == 0)
            {
                OutputListView.HeaderStyle = ColumnHeaderStyle.None;
                OutputListView.Items.Add("Office number not found.");
            }
        }

        private void SearchTelephone()
        {
            string tele = TelephoneTextBox.Text.Trim(' ');
            if(!IsValidTelephone(tele))
            {
                OutputListView.HeaderStyle = ColumnHeaderStyle.None;
                OutputListView.Items.Add(INVALID_TELEPHONE);
                return;
            }

            foreach(Person person in PersonList)
            {
                if(person.Telephone == tele)
                {
                    var item = new ListViewItem(new[] { person.Name, person.Office, person.Telephone });
                    OutputListView.Items.Add(item);
                }
            }

            if(OutputListView.Items.Count == 0)
            {
                OutputListView.HeaderStyle = ColumnHeaderStyle.None;
                OutputListView.Items.Add(INVALID_TELEPHONE);
            }
        }

        private void ChangeOffice()
        {
            OutputListView.HeaderStyle = ColumnHeaderStyle.None;

            string input = NameTextBox.Text.Trim(' ');
            bool valid = true;
            if(!IsValidName(input))
            {
                OutputListView.Items.Add(INVALID_NAME);
                valid = false;
            }

            if(SearchName(input) == -1 && valid)
            {
                OutputListView.Items.Add("Entered name does not exist.");
                valid = false;
            }

            int idx = SearchName(input);
            input = OfficeTextBox.Text.Trim(' ');

            if(!IsValidOffice(input))
            {
                OutputListView.Items.Add(INVALID_OFFICE);
                valid = false;
            }

            if (valid)
            {
                PersonList[idx].Office = input;
                OutputListView.Items.Add("Office number changed.");
            }
        }

        private void AddEntry()
        {
            OutputListView.HeaderStyle = ColumnHeaderStyle.None;

            string name = NameTextBox.Text.Trim(' ');
            string office = OfficeTextBox.Text.Trim(' ');
            string tele = TelephoneTextBox.Text.Trim(' ');

            bool valid = true;
            if(!IsValidName(name))
            {
                OutputListView.Items.Add(INVALID_NAME);
                valid = false;
            }

            if (SearchName(name) != -1)
            {
                OutputListView.Items.Add("Entered name already exists.");
                valid = false;
            }

            if (!IsValidOffice(office))
            {
                OutputListView.Items.Add(INVALID_OFFICE);
                valid = false;
            }

            if(!IsValidTelephone(tele))
            {
                OutputListView.Items.Add(INVALID_TELEPHONE);
                valid = false;
            }

            if (valid)
            {
                PersonList.Add(new Person(name, office, tele));
                OutputListView.Items.Add("New entry added.");
            }
        }

        private void RemoveEntry() 
        {
            OutputListView.HeaderStyle = ColumnHeaderStyle.None;

            string name = NameTextBox.Text.Trim(' ');
            if(SearchName(name) != -1) 
            {
                PersonList.Remove(PersonList[SearchName(name)]);
                OutputListView.Items.Add("Entry successfully removed.");
                return;
            }

            OutputListView.Items.Add("Entry with entered name not found, no entry removed.");
        }

        private static bool IsValidOffice(string office)
        {
            if (office.Length < 1) return false;
            
            foreach (char c in office) 
            {
                if (c == ' ') return false;
            }

            return true;
        }

        private static bool IsValidTelephone(string tele) 
        {
            if (tele.Length != 12 || tele[3] != '-' || tele[7] != '-') return false;

            return Int32.TryParse(tele.Substring(0, 3), out _) && 
            Int32.TryParse(tele.Substring(4, 3), out _) && Int32.TryParse(tele.Substring(8, 4), out _);
        }

        private static bool IsValidName(string name)
        {
            if (name.Length < 1) return false;

            foreach (char c in name)
            {
                if (Char.IsNumber(c) || c == ' ' || (Char.IsPunctuation(c) && c != '-')) return false;
            }

            return true;
        }

        private void WriteFile()
        {
            string fileName = InputFileDialog.FileName;

            if(fileName == "")
                return;

            using StreamWriter outFile = new(fileName);
            foreach(Person person in PersonList)
            {
                outFile.Write(person.Name + " ");
                outFile.Write(person.Office + " ");
                outFile.Write(person.Telephone + " ");
                outFile.WriteLine();
            }
        }
    }

    public class Person : IComparable
    {
        public string Name { get; set; }
        public string Office { get; set; }
        public string Telephone { get; set; }

        public Person(string Name, string Office, string Telephone)
        {
            this.Name = Name;
            this.Office = Office;
            this.Telephone = Telephone;
        }

        public int CompareTo(object? OBJ)
        {
            if (OBJ is not Person comparePerson) return 1;

            if (Name.CompareTo(comparePerson.Name) == 0) return 0;
            else if (Name.CompareTo(comparePerson.Name) < 0) return -1;
            else return 1;
        }
    }
}