using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct a
        {
            public string f;
            public string i;
            public string o;
            public double age;
            public double ves;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void выполнитьВозврастаМеньше40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a str;
            StreamReader sw = new StreamReader("r1.txt");
            Hashtable people = new Hashtable();
            string a, b;
            while ((a = sw.ReadLine()) != null)
            {
                string[] mas = a.Split(' ');
                str.f = mas[0];
                str.i = mas[1];
                str.o = mas[2];
                str.age = float.Parse(mas[3]);
                str.ves = float.Parse(mas[4]);
                if (str.age < 40)
                {
                    MessageBox.Show($"ФИО - {str.f}, {str.i}, {str.o} \n Возвраст {str.age} \n Вес {str.ves}");
                }
            }
        }
        private void выполнитьДляВоврастаБольше40ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a str;
            StreamReader sw = new StreamReader("r1.txt");
            Hashtable people = new Hashtable();
            string a, b;
            while ((a = sw.ReadLine()) != null)
            {
                string[] mas = a.Split(' ');
                str.f = mas[0];
                str.i = mas[1];
                str.o = mas[2];
                str.age = float.Parse(mas[3]);
                str.ves = float.Parse(mas[4]);
                if (str.age > 40)
                {
                    MessageBox.Show($"ФИО - {str.f}, {str.i}, {str.o} \n Возвраст {str.age} \n Вес {str.ves}");
                }
            }
        }
        private void выполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Departament> department = new List<Departament>()
            {
                new Departament { Name = "Отдел закупок", Reg ="Германия" },
                new Departament { Name = "Отдел продаж", Reg ="Испания" },
                new Departament { Name = "Отдел маркетинга", Reg ="Россия" }
            };

            List<Employ> employes = new List<Employ>()
            {
                    new Employ {Name="Иванов", Departament ="Отдел закупок"},
                    new Employ {Name="Петров", Departament ="Отдел закупок"},
                    new Employ {Name="Сидоров", Departament ="Отдел продаж"},
                    new Employ {Name="Лямин", Departament ="Отдел продаж "},
                    new Employ {Name="Сидоренко", Departament ="Отдел маркетинга"},
                    new Employ {Name="Кривоносов", Departament ="Отдел продаж "}
            };

            var result = from nm in employes
                         join t in department on nm.Departament equals t.Name
                         select new { Name = nm.Name, Departament = nm.Departament, Reg = t.Reg };

            //var result = department.Join(employes,
            //p => p.Name,
            //t => t.Departament,
            //(p, t) => new
            //{
            //    Name = t.Name,
            //    Reg = p.Reg,
            //    Departament = t.Departament
            //});

                foreach (var mb in result)
                {
                    if (mb.Reg.StartsWith("И"))
                    label2.Text=  ($"{mb.Name} - {mb.Departament} ({mb.Reg}) \n" +label2.Text +" ");
                    
                }
            

                

        }

        private void регионНачинаетсяНаИToolStripMenuItem_Click(object sender, EventArgs e)
        {
             List<Departament> department = new List<Departament>()
             {
                new Departament { Name = "Отдел закупок", Reg ="Германия"},
                new Departament { Name = "Отдел продаж", Reg ="Испания"},
                new Departament { Name = "Отдел маркетинга", Reg ="Россия"}
             };

            List<Employ> employes = new List<Employ>()
            {
                    new Employ {Name="Иванов", Departament ="Отдел закупок"},
                    new Employ {Name="Петров", Departament ="Отдел закупок"},
                    new Employ {Name="Сидоров", Departament ="Отдел продаж"},
                    new Employ {Name="Лямин", Departament ="Отдел продаж "},
                    new Employ {Name="Сидоренко", Departament ="Отдел маркетинга"},
                    new Employ {Name="Кривоносов", Departament ="Отдел продаж "}
            };

            var result = from nm in employes
            join t in department on nm.Departament equals t.Name
            select new { Name = nm.Name, Departament = nm.Departament, Reg = t.Reg };


            
            






        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
