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
        Random rnd = new Random();

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
                            cat.NeedsPet();
                            Animals.Add(cat);
                            AnimalInfo.Add(NameAnimal);
                            listBox1.Items.Add(NameAnimal);
                            break;
                        case "Dog":
                            Dog dog = new Dog(nameBox, (int)AgeBox.Value, ownerBox, (int)UniquenessBox.Value);
                            NameAnimal = "Dog: " + nameBox + " , Owner: " + ownerBox;
                            dog.NeedsPet();
                            Animals.Add(dog);
                            AnimalInfo.Add(NameAnimal);
                            listBox1.Items.Add(NameAnimal);
                            break;
                        case "Raccoon":
                            Raccoon raccoon = new Raccoon(nameBox, (int)AgeBox.Value, ownerBox, (int)UniquenessBox.Value);
                            NameAnimal = "Raccoon: " + nameBox + " , Owner: " + ownerBox;
                            raccoon.NeedsPet();
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
                Animal newAnimal = Animals[listBox1.SelectedIndex];
                char[] NameAnimal = AnimalInfo[listBox1.SelectedIndex].ToCharArray();

                if (NameAnimal[0] == 'C')
                {
                    if (radioFeed.Checked)
                    {
                        presenter.Feed(newAnimal, FoodBox.Text);
                        OnSuccessFeed(newAnimal, FoodBox.Text);
                    }
                    else if (radioSleep.Checked)
                    {
                        presenter.Sleep(newAnimal, (int)sleepBox.Value);
                        OnSuccessSleep(newAnimal, (int)sleepBox.Value);
                    }
                    else if (radioTraining.Checked)
                    {
                        presenter.Training(newAnimal, CommandBox.Text, (int)starBox.Value);
                        OnSuccessTraining(newAnimal, CommandBox.Text, (int)starBox.Value);
                    }
                    else if (radioWalk.Checked)
                    {
                        presenter.Walk(newAnimal, (int)speedBox.Value, placeBox.Text, (int)timeBox.Value);
                        OnSuccessWalk(newAnimal, (int)speedBox.Value, placeBox.Text, (int)timeBox.Value);
                    }
                    else
                    {
                        ErrorDo();
                    }

                }
                else if (NameAnimal[0] == 'D')
                {
                    if (radioFeed.Checked)
                    {
                        presenter.Feed(newAnimal, FoodBox.Text);
                        OnSuccessFeed(newAnimal, FoodBox.Text);
                    }
                    else if (radioSleep.Checked)
                    {
                        presenter.Sleep(newAnimal, (int)sleepBox.Value);
                        OnSuccessSleep(newAnimal, (int)sleepBox.Value);
                    }
                    else if (radioTraining.Checked)
                    {
                        presenter.Training(newAnimal, CommandBox.Text, (int)starBox.Value);
                        OnSuccessTraining(newAnimal, CommandBox.Text, (int)starBox.Value);
                    }
                    else if (radioWalk.Checked)
                    {
                        presenter.Walk(newAnimal, (int)speedBox.Value, placeBox.Text, (int)timeBox.Value);
                        OnSuccessWalk(newAnimal, (int)speedBox.Value, placeBox.Text, (int)timeBox.Value);
                    }
                    else
                    {
                        ErrorDo();
                    }
                }
                else if (NameAnimal[0] == 'R')
                {
                    if (radioFeed.Checked)
                    {
                        presenter.Feed(newAnimal, FoodBox.Text);
                        OnSuccessFeed(newAnimal, FoodBox.Text);
                    }
                    else if (radioSleep.Checked)
                    {
                        presenter.Sleep(newAnimal, (int)sleepBox.Value);
                        OnSuccessSleep(newAnimal, (int)sleepBox.Value);
                    }
                    else if (radioTraining.Checked)
                    {
                        presenter.Training(newAnimal, CommandBox.Text, (int)starBox.Value);
                        OnSuccessTraining(newAnimal, CommandBox.Text, (int)starBox.Value);
                    }
                    else if (radioWalk.Checked)
                    {
                        presenter.Walk(newAnimal, (int)speedBox.Value, placeBox.Text, (int)timeBox.Value);
                        OnSuccessWalk(newAnimal, (int)speedBox.Value, placeBox.Text, (int)timeBox.Value);
                    }
                    else
                    {
                        ErrorDo();
                    }
                }
                else
                {
                    ErrorDo();

                }
            }
        }

        public void OnSuccessFeed(Animal animal, string food)
        {
            PepBox.Text = Convert.ToString(animal.Pep);
            MoodBox.Text = Convert.ToString(animal.Mood);
            IntelBox.Text = Convert.ToString(animal.Intelligence);
            SatietyBox.Text = Convert.ToString(animal.Satiety);
        }

        public void OnSuccessWalk(Animal animal, int speed, string place, int time)
        {
            PepBox.Text = Convert.ToString(animal.Pep);
            MoodBox.Text = Convert.ToString(animal.Mood);
            IntelBox.Text = Convert.ToString(animal.Intelligence);
            SatietyBox.Text = Convert.ToString(animal.Satiety);
        }

        public void OnSuccessTraining(Animal animal, string command, int star)
        {
            PepBox.Text = Convert.ToString(animal.Pep);
            MoodBox.Text = Convert.ToString(animal.Mood);
            IntelBox.Text = Convert.ToString(animal.Intelligence);
            SatietyBox.Text = Convert.ToString(animal.Satiety);
        }

        public void OnSuccessSleep(Animal animal, int hours)
        {
            PepBox.Text = Convert.ToString(animal.Pep);
            MoodBox.Text = Convert.ToString(animal.Mood);
            IntelBox.Text = Convert.ToString(animal.Intelligence);
            SatietyBox.Text = Convert.ToString(animal.Satiety);
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = Animals[listBox1.SelectedIndex];
            char[] NameAnimal = AnimalInfo[listBox1.SelectedIndex].ToCharArray();
            string Who="";

            PepBox.Text = Convert.ToString(animal.Pep);
            MoodBox.Text = Convert.ToString(animal.Mood);
            IntelBox.Text = Convert.ToString(animal.Intelligence);
            SatietyBox.Text = Convert.ToString(animal.Satiety);

            NameIs.Text = Convert.ToString(animal.Name);
            AgeIs.Text = Convert.ToString(animal.Age);
            OwnerIs.Text = Convert.ToString(animal.Owner);
            if (NameAnimal[0] == 'C')
            {
                AnimalBox.Text = "Cat";
                Who = "Harmfulness: " + animal.GetUniq();
            }
            else if (NameAnimal[0] == 'D')
            {
                AnimalBox.Text = "Dog";
                Who = "Danger: " + animal.GetUniq();
            }
            else if (NameAnimal[0] == 'R')
            {
                AnimalBox.Text = "Raccoon";
                Who = "Fluff: " + animal.GetUniq();
            }
            uniqText.Text = Convert.ToString(Who);
            IdBox.Text = Convert.ToString(animal.GetId());
        }
    }
}
