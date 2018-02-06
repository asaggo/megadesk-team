﻿using System;
using System.Collections.Generic;
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
                    materialCost = (int)SurfaceMaterial.Laminate;
                    break;
                case "Oak":
                    materialCost = (int)SurfaceMaterial.Oak;
                    break;
                case "Pine":
                    materialCost = (int)SurfaceMaterial.Pine;
                    break;
                case "Rosewood":
                    materialCost = (int)SurfaceMaterial.Rosewood;
                    break;
                case "Veneer":
                    materialCost = (int)SurfaceMaterial.Veneer;
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
            if (size < 1000)
            {
                if (rushOrderDays.Equals("3 days"))
                    rushOrderCost = 60;
                else if (rushOrderDays.Equals("5 days"))
                    rushOrderCost = 40;
                else if (rushOrderDays.Equals("7 days"))
                    rushOrderCost = 30;
                else
                    rushOrderCost = 0;
            }
            else if (size >= 1000 || size <= 2000)
            {
                if (rushOrderDays.Equals("3 days"))
                    rushOrderCost = 70;
                else if (rushOrderDays.Equals("5 days"))
                    rushOrderCost = 50;
                else if (rushOrderDays.Equals("7 days"))
                    rushOrderCost = 35;
                else
                    rushOrderCost = 0;
            }
            else //(size > 2000) //need to check
            {
                if (rushOrderDays.Equals("3 days"))
                    rushOrderCost = 80;
                else if (rushOrderDays.Equals("5 days"))
                    rushOrderCost = 60;
                else if (rushOrderDays.Equals("7 days"))
                    rushOrderCost = 40;
                else
                    rushOrderCost = 0;
            }
            
        }

        public void CalcTotalCost()
        {
            totalCost = oversizeCost + materialCost + drawerCost + rushOrderCost + 200;
        }
    }
}
