using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsLesson
{
    public partial class Form1 : Form, MainView
    {
        Presenter presenter;

        public Form1()
        {
            InitializeComponent();

            presenter = new Presenter(new AnimalAction());
        }

        List<Animal> Animals = new List<Animal>();
        List<string> AnimalInfo = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameBox.Text.Trim() != "" && OwnerBox.Text.Trim() != "")
            {
                string nameBox = NameBox.Text.Trim();
                string ownerBox = OwnerBox.Text.Trim();
                if (CheckChar(nameBox) && CheckChar(ownerBox))
                {
                    string NameAnimal;
                    switch (PetsIs.Text)
                    {

                        case "Cat":
                            Cat cat = new Cat(nameBox, (int)AgeBox.Value, ownerBox, (int)UniquenessBox.Value);
                            NameAnimal = "Cat: " + nameBox + " , Owner: " + ownerBox;
                            Animals.Add(cat);
                            AnimalInfo.Add(NameAnimal);
                            listBox1.Items.Add(NameAnimal);
                            break;
                        case "Dog":
                            Dog dog = new Dog(nameBox, (int)AgeBox.Value, ownerBox, (int)UniquenessBox.Value);
                            NameAnimal = "Dog: " + nameBox + " , Owner: " + ownerBox;
                            Animals.Add(dog);
                            AnimalInfo.Add(NameAnimal);
                            listBox1.Items.Add(NameAnimal);
                            break;
                        case "Raccoon":
                            Raccoon raccoon = new Raccoon(nameBox, (int)AgeBox.Value, ownerBox, (int)UniquenessBox.Value);
                            NameAnimal = "Raccoon: " + nameBox + " , Owner: " + ownerBox;
                            Animals.Add(raccoon);
                            AnimalInfo.Add(NameAnimal);
                            listBox1.Items.Add(NameAnimal);
                            break;
                        default:
                            ErrorCheckPet();
                            break;
                    }
                }
                else
                {
                    ErrorFormat();
                }
            }
            else
            {
                ErrorMessageNull();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Animal newAnimal=Animals[listBox1.SelectedIndex];
                char[] NameAnimal = AnimalInfo[listBox1.SelectedIndex].ToCharArray();

                if (NameAnimal[0] == 'C')
                {
                if (radioFeed.Checked)
                {
                        OnSuccessFeed(newAnimal, FoodBox.Text);
                }
                else if (radioSleep.Checked)
                {

                }
                else if (radioTraining.Checked)
                {

                }
                else if (radioWalk.Checked)
                {

                }
                    else
                    {
                        ErrorDo();
                    }
                    
                }
               
            }
        }

        public void OnSuccessFeed(Animal animal, string food)
        {
            PepBox.Text = Convert.ToString(animal.Pep);

        }

        public void OnSuccessWalk(string animal, int speed, string place, int time)
        {

        }

        public void OnSuccessTraining(string animal, string command, int star)
        {

        }

        public void OnSuccessSleep(string animal, int hours)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            this.Hide();
            newForm.Show();
        }

        public void ErrorMessageNull()
        {

        }

        public bool CheckChar(string CheckThis)
        {
            return true;
        }

        public void ErrorCheckPet()
        {

        }

        public void ErrorFormat()
        {

        }

        public void ErrorDo()
        {

        }
    }
}
