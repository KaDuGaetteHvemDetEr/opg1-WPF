using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Threading;

namespace opg1_WPF
{

    class ClassBIZ
    {
        public ClassBIZ()
        {

        }
        public void Delopgave12(ListBox listBox)
        {
            listBox.Items.Clear();


            for (int i = 4711; i < 4737; i++)
            {
                listBox.Items.Add(i.ToString());
            }

        }
        public void Delopgave13(ListBox listBox)
        {
            Random random = new Random();

            listBox.Items.Clear();

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal.ToString());
            }
        }


        public void Delopgave14(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();

            listBox.Items.Clear();

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt.Add(randomTal);
            }

            listInt.Sort();
            foreach (int tal in listInt)
            {
                listBox.Items.Add(tal.ToString());

            }











        }
        public void Delopgave15(ListBox listBox)
        {
            Random random = new Random();
            List<int> listInt1 = new List<int>();
            List<int> listInt2 = new List<int>();

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listInt1.Add(randomTal);
                listInt2.Add(randomTal);
            }

            listInt2.Sort();

            for (int i = 0; i < listInt1.Count; i++)
            {
                listBox.Items.Add($"{listInt1[i]} - {listInt2[i]}");
            }



        }

        public void Delopgave16(ListBox listBox)
        {
            Random random = new Random();
            List<int> listINt = new List<int>();

            listBox.Items.Clear();

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal);
                listINt.Add(randomTal);

            }




            listBox.Items.Add("");
            listBox.Items.Add($"Gennemsnitsværdi  :  {GetAverageValue(listINt)}");







        }
        private int GetAverageValue(List<int> list)
        {
            int intRes = 0;
            int intCount = 0;

            foreach (int tal in list)
            {
                intRes += tal;
                intCount++;

            }

            intRes = intRes / intCount;

            return intRes;
        }

        public void Delopgave17(ListBox listBox)
        {
            Random random = new Random();
            List<int> listINt = new List<int>();

            listBox.Items.Clear();



            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                listBox.Items.Add(randomTal);
                listINt.Add(randomTal);
            }
            listBox.Items.Add("");
            listBox.Items.Add($"Gennemsnitsværdi  :  {GetAverageValue(listINt)}");

            foreach (int tal in listINt)
            {
                int intAverage = GetAverageValue(listINt);
                listBox.Items.Add($"{tal} - {intAverage} = {tal - intAverage}");
            }
        }

        public List<string> Delopgave18(ListBox listBox)
        {
            Random random = new Random();
            List<int> ListInt = new List<int>();
            List<string> listRes = new List<string>();

            int intAverage = 0;

            for (int i = 0; i < 25; i++)
            {
                int randomTal = random.Next(100000, 1000001);
                ListInt.Add(randomTal);
            }

            intAverage = GetAverageValue(ListInt);

            ListInt.Sort();

            foreach (int tal in ListInt)
            {
                listRes.Add($"{tal} + {intAverage} = {tal + intAverage}");
            }

            return listRes;
        }

        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }



    }
}
