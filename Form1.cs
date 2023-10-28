using lw1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace L55
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private List<Door> doors = new List<Door>();

        public Form1()
        {
            InitializeComponent();
            materialComboBox.DataSource = Enum.GetValues(typeof(DoorMaterial));
            typeComboBox.DataSource = Enum.GetValues(typeof(DoorType));
            displayFormatComboBox.DataSource = Enum.GetValues(typeof(DoorInfoType));

            displayFormatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private bool IsValidInput()
        {
            int parsedValue;
            if (!int.TryParse(heightTextBox.Text, out parsedValue) || parsedValue <= 0 || parsedValue >= 200)
            {
                MessageBox.Show("Please enter a valid height (1-199 cm).");
                return false;
            }

            int windowsValue;
            if (!int.TryParse(amountOfWindowsTextBox.Text, out windowsValue) || windowsValue <= 0 || windowsValue >= 5)
            {
                MessageBox.Show("Please enter a valid number of windows (1-4).");
                return false;
            }

            if (materialComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a material.");
                return false;
            }

            if (typeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type.");
                return false;
            }

            return true;
        }


        private void DisplayDoors()
        {
            doorsListBox.Items.Clear();
            foreach (Door door in doors)
            {
                doorsListBox.Items.Add(door.DoorSign);
            }
        }

        private void ClearInputFields()
        {
            heightTextBox.Clear();
            doorSignTextBox.Clear();
            isOpenedCheckBox.Checked = false;
            amountOfWindowsTextBox.Clear();
            materialComboBox.SelectedIndex = -1;
            typeComboBox.SelectedIndex = -1;
        }

        private void DisplayDoor(Door door)
        {
            MessageBox.Show(door.GetDoorInfo());
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddObjectButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayDoors();
        }


        private void FindObjectButton_Click_1(object sender, EventArgs e)
        {
            string searchDoorSign = searchTextBox.Text;
            Door foundDoor = doors.Find(d => d.DoorSign.Equals(searchDoorSign, StringComparison.OrdinalIgnoreCase));

            if (foundDoor != null)
            {
                DisplayDoor(foundDoor);
            }
            else
            {
                MessageBox.Show("Door not found.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (doorsListBox.SelectedIndex >= 0)
            {
                Door doorToDelete = doors[doorsListBox.SelectedIndex];
                Door.RemoveDoor(doors, doorToDelete);
                DisplayDoors();
                refreshLabel4();
            }
            else
            {
                MessageBox.Show("Select a door from the list.");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (doorsListBox.SelectedIndex >= 0)
            {
                Door selectedDoor = doors[doorsListBox.SelectedIndex];
                if (displayFormatComboBox.SelectedItem is DoorInfoType format)
                {
                    MessageBox.Show(selectedDoor.GetDoorInfo(format));
                }
                else
                {
                    MessageBox.Show("Select an info type from the list.");
                }
            }
            else
            {
                MessageBox.Show("Select a door from the list.");
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void displayFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = amountOfWindowsTextBox.Text;
            Door newDoor;
            if (Door.TryParse(input, out newDoor))
            {
                doors.Add(newDoor);
                ClearInputFields();
                DisplayDoors();
                refreshLabel4();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter door properties in the correct format.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string GenerateRandomDoorString()
        {
            Random random = new Random();
            string doorSign = $"Door{random.Next(1, 100)}";
            DoorMaterial material = (DoorMaterial)random.Next(0, Enum.GetValues(typeof(DoorMaterial)).Length);
            DoorType type = (DoorType)random.Next(0, Enum.GetValues(typeof(DoorType)).Length);
            int height = random.Next(1, 200);
            int amountOfWindows = random.Next(1, 5);
            bool isOpened = random.Next(2) == 0;

            string randomString = $"{doorSign},{material},{type},{height},{amountOfWindows},{isOpened}";

            return randomString;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            refreshLabel4();
        }

        private void refreshLabel4()
        {
            int objectCount = Door.ObjectCount;
            label4.Text = objectCount.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (doorsListBox.SelectedIndex >= 0)
            {
                Door selectedDoor = doors[doorsListBox.SelectedIndex];
                MessageBox.Show($"Is Solid: {selectedDoor.isSolid()}");
            }
            else
            {
                MessageBox.Show("Select a door from the list.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Description: {Door.DoorDescription}");
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayDoors();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string randomString = GenerateRandomDoorString();
            textBox1.Text = randomString;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string input = GenerateRandomDoorString();
            Door newDoor;
            if (Door.TryParse(input, out newDoor))
            {
                doors.Add(newDoor);
                ClearInputFields();
                DisplayDoors();
                refreshLabel4();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter door properties in the correct format.");
            }
        }

        private void AddObjectButton_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                Door newDoor = new Door();
                newDoor.Height = int.Parse(heightTextBox.Text);
                newDoor.DoorSign = doorSignTextBox.Text;
                newDoor.IsOpened = isOpenedCheckBox.Checked;
                newDoor.AmountOfWindows = int.Parse(amountOfWindowsTextBox.Text);
                newDoor.Material = (DoorMaterial)materialComboBox.SelectedItem;
                newDoor.Type = (DoorType)typeComboBox.SelectedItem;

                doors.Add(newDoor);
                ClearInputFields();
                DisplayDoors();
                refreshLabel4();
            }
        }

        private void FindObjectButton_Click(object sender, EventArgs e)
        {
            string searchDoorSign = searchTextBox.Text;
            Door foundDoor = doors.Find(d => d.DoorSign.Equals(searchDoorSign, StringComparison.OrdinalIgnoreCase));

            if (foundDoor != null)
            {
                DisplayDoor(foundDoor);
            }
            else
            {
                MessageBox.Show("Door not found.");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            Door newDoor;
            if (Door.TryParse(input, out newDoor))
            {
                doors.Add(newDoor);
                ClearInputFields();
                DisplayDoors();
                refreshLabel4();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter door properties in the correct format.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (doorsListBox.SelectedIndex >= 0)
            {
                Door selectedDoor = doors[doorsListBox.SelectedIndex];
                if (displayFormatComboBox.SelectedItem is DoorInfoType format)
                {
                    MessageBox.Show(selectedDoor.GetDoorInfo(format));
                }
                else
                {
                    MessageBox.Show("Select an info type from the list.");
                }
            }
            else
            {
                MessageBox.Show("Select a door from the list.");
            }
        }
    }
}
