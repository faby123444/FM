using FactoryMeth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM
{
	public partial class Form1 : Form
	{
		private List<Animal> listaAnimales;
		private Random random;

		public Form1()
		{
			InitializeComponent();
			InitializeAnimales();
			random = new Random();
		}

		private void InitializeAnimales()
		{
			listaAnimales = new List<Animal>
			{
				new Vaca(),
				new Pajaro(),
				new Serpiente()
			};
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			UpdateAnimalImage();
		}

		private void btnGenerarAnimal_Click(object sender, EventArgs e)
		{
			UpdateAnimalImage();
		}

		private void UpdateAnimalImage()
		{
			Animal animal = listaAnimales[random.Next(listaAnimales.Count)];
			string animalName = animal.Render();

			lblAnimal.Text = animalName;

			// Actualizar la imagen del PictureBox
			Image image = GetAnimalImage(animalName);
			pictureBoxAnimal.Image = image;
		}

		private Image GetAnimalImage(string animalName)
		{
			switch (animalName)
			{
				case "Vaca":
					return Properties.Resources.Vaca;
				case "Pajaro":
					return Properties.Resources.Pajaro;
				case "Serpiente":
					return Properties.Resources.Serpiente;
				default:
					return null;
			}
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{

		}
	}
}
