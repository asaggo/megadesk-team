using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_JessieJi
{
    class DeskQuotes
    {
        private Desk desk;
        private int size;
        private int oversize;
        private double oversizeCost, materialCost, drawerCost, rushOrderCost, totalCost;
        public int Oversize { get { return oversize; } set { oversize = value; } }
        public double OversizeCost { get { return oversizeCost; } set { oversizeCost = value; } }
        public double MaterialCost { get { return materialCost; } set { materialCost = value; } }
        public double DrawerCost { get { return drawerCost; } set { drawerCost = value; } }
        public double RushOrderCost { get { return rushOrderCost; } set { rushOrderCost = value; } }
        public double TotalCost { get { return totalCost; } set { totalCost = value; } }
        public int Size { get { return size; } set { size = value; } }
        public DeskQuotes(Desk desk)
        {
            this.desk = desk;
        } 
        
        public void CalcOversizeCost()
        {
            int width = desk.Width;
            int depth = desk.Depth;
            size = width * depth;
            oversize = size > 1000 ? size - 1000: 0;
            if (oversize > 0) //not necessary to have if statement here. maybe later I can use try and catch
                oversizeCost = oversize;
        }

        public void CalcMtrlCost(string material)
        {
            switch (material)
            {
                case "Laminate":
                    materialCost = (int)Desk.SurfaceMaterial.Laminate;
                    break;
                case "Oak":
                    materialCost = (int)Desk.SurfaceMaterial.Oak;
                    break;
                case "Pine":
                    materialCost = (int)Desk.SurfaceMaterial.Pine;
                    break;
                case "Rosewood":
                    materialCost = (int)Desk.SurfaceMaterial.Rosewood;
                    break;
                case "Veneer":
                    materialCost = (int)Desk.SurfaceMaterial.Veneer;
                    break;
                default: //error or empty
                    materialCost = 0;
                    break;
            }
            
        }

        public void CalcDrawerCost()
        {
            drawerCost = desk.NumDrawers * 50;
        }

        public void CalcRushOrderCost(string rushOrderDays)
        {
            int[,] rushorderArray = new int[3, 3];
            string[] lines = File.ReadAllLines("rushOrderPrices.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                int row = i / 3;
                int col = i % 3;
                rushorderArray[row, col] = Convert.ToInt32(lines[i]);
            }

            int r, c = 0;
            if (rushOrderDays.Equals("3 days"))
                r = 0;
            else if (rushOrderDays.Equals("5 days"))
                r = 1;
            else if (rushOrderDays.Equals("7 days"))
                r = 2;
            else //no rush
            {
                rushOrderCost = 0;
                return;
            }
           
            if (size < 1000)
                c = 0;
            else if (size >= 1000 && size <= 2000)
                c = 1;
            else //size > 2000
                c = 2;

            rushOrderCost = rushorderArray[r, c];
        }

        public void CalcTotalCost()
        {
            totalCost = oversizeCost + materialCost + drawerCost + rushOrderCost + 200;
        }
    }
}
