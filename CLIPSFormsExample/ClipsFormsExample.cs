using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CLIPSNET;


namespace ClipsFormsExample
{
    public partial class ClipsFormsExample : Form
    {
        private string MainStrFacts = "";

        private string MainStrRules = "";

        private bool IsReset = false;

        private List<FactInstance> Lst;

        private FactInstance Target;

        private CLIPSNET.Environment clips = new CLIPSNET.Environment();

        public ClipsFormsExample()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            outputBox.ReadOnly = true;
        }

        private void HandleResponse()
        {
            clips.Run();
            List <FactInstance> NewLst = clips.GetFactList();
            List<FactInstance> ItemLst = new List<FactInstance> { };
            bool b = true;
            for (int i = 0; i < NewLst.Count(); i++)
            {
                var item = NewLst[i];
                if (item.RelationName == "message")
                {
                    ItemLst.Add(item);
                    outputBox.Text += "-> "+MinusRElem(item.GetSlotValues()[0])+" = "+ MinusRElem(item.GetSlotValues()[1]) + System.Environment.NewLine;
                }

                if ((item.GetSlotValues()[0].ToString() == "1)")&&(item.GetSlotValues()[1].ToString() == Target.GetSlotValues()[1].ToString()))
                    b = false;
            }

            Lst = NewLst;
            Target = Lst[comboBox2.SelectedIndex];

            if (b)
                outputBox.Text += "    " + MinusRElem(Target.GetSlotValues()[2]) + " Не выводим " + System.Environment.NewLine;
            else
                outputBox.Text += "    " + MinusRElem(Target.GetSlotValues()[2]) + " Выводим = "+ MinusRElem(Target.GetSlotValues()[3]) + System.Environment.NewLine;

            foreach (var item in ItemLst)
                clips.Eval("(retract "+ MinusFElem(item.Name)+")");
        }

        private void resButton_Click(object sender, EventArgs e)
        {
            if (!IsReset)
            {
                MessageBox.Show("Добавте правила и факты!");
                return;
            }
            Target = Lst[comboBox2.SelectedIndex];
            HandleResponse();
        }

        private void Reset()
        {
            textBox1.Text = "";

            outputBox.Text = "Start" + System.Environment.NewLine;

            clips.Clear();

            clips.LoadFromString(MainStrFacts + MainStrRules);

            clips.Reset();

            Lst = clips.GetFactList();

            PrintComboBoxs();

            IsReset = true;
        }

        private void PrintComboBoxs()
        {
            List<string> arr = new List<string> { };
            foreach (var item in Lst)
                arr.Add(MinusRElem(item.GetSlotValues()[2]));
            string[] a = arr.ToArray();

            List<string> arr1 = new List<string> { };
            foreach (var item in Lst)
                arr1.Add(MinusRElem(item.GetSlotValues()[2])+" = "+ MinusRElem(item.GetSlotValues()[3]));
            string[] a1 = arr1.ToArray();

            comboBox1.Items.AddRange(a1);
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(a);
            comboBox2.SelectedIndex = 0;
        }

        private string MinusRElem(SlotValue S)
        {
            return S.ToString().Split(')')[0];
        }

        private string MinusFElem(string str)
        {
            return str.Split('-')[1];
        }

        private void openButtonFacts_Click(object sender, EventArgs e)
        {
            if (clipsOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainStrFacts += System.IO.File.ReadAllText(clipsOpenFileDialog.FileName);
                Text = "Экспертная система \"Продукты\" – " + clipsOpenFileDialog.FileName;
            }
            if(MainStrRules!="")
                Reset();
        }

        private void openButtonRules_Click(object sender, EventArgs e)
        {
            if (clipsOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainStrRules += System.IO.File.ReadAllText(clipsOpenFileDialog.FileName);
                Text = "Экспертная система \"Продукты\" – " + clipsOpenFileDialog.FileName;
            }
            if (MainStrFacts != "")
                Reset();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!IsReset)
            {
                MessageBox.Show("Добавте правила и факты!");
                    return;
            }
            var i = Lst[comboBox1.SelectedIndex];
            if (i.GetSlotValues()[0].ToString() == "0)")
            {
                textBox1.Text += comboBox1.Text + System.Environment.NewLine;
                clips.Eval("(modify " + MinusFElem(i.Name) +" (is 1 )) ");
            }
            Lst = clips.GetFactList();
            PrintComboBoxs();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (!IsReset)
            {
                MessageBox.Show("Добавте правила и факты!");
                return;
            }
            Reset();
        }
    }
}
