using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    class Desk
    {
        private decimal _width;
        private decimal _depth;
        private int _numberOfDrawer;
        private string _surfaceMaterial;
        private int _rushOrderDay;

        public Desk(decimal width, decimal depth, int numberOfDrawer, string surfaceMaterial, int rushOrderDay)
        {
            _width = width;
            _depth = depth;
            _numberOfDrawer = numberOfDrawer;
            _surfaceMaterial = surfaceMaterial;
            _rushOrderDay = rushOrderDay;
        }

        public decimal Width { get { return this._width; } set { this._width = value; } }
        public decimal Depth { get { return this._depth; } set { this._depth = value; } }
        public int NumberOfDrawer { get { return this._numberOfDrawer; } set { this._numberOfDrawer = value; } }
        public string SurfaceMaterial { get { return this._surfaceMaterial; } set { this._surfaceMaterial = value; } }
        public int RushOrderDay { get { return this._rushOrderDay; } set { this._rushOrderDay = value; } }

        public decimal computeSurfaceArea(decimal width, decimal height)
        {
            return width * height;
        }

        public decimal computeShippingCost()
        {
            decimal totalSurfaceArea = computeSurfaceArea(_width, _depth);
            decimal rushOrderCost;
            if (_rushOrderDay == 3)
            {
                if (totalSurfaceArea < 1000)
                {
                    rushOrderCost = 60;
                }
                else if (totalSurfaceArea >= 100 && totalSurfaceArea <= 2000)
                {
                    rushOrderCost = 70;
                }
                else
                {
                    rushOrderCost = 80;
                }
            }
            else if (_rushOrderDay == 5)
            {
                if (totalSurfaceArea < 1000)
                {
                    rushOrderCost = 40;
                }
                else if (totalSurfaceArea >= 100 && totalSurfaceArea <= 2000)
                {
                    rushOrderCost = 50;
                }
                else
                {
                    rushOrderCost = 60;
                }
            }
            else if (_rushOrderDay == 7)
            {
                if (totalSurfaceArea < 1000)
                {
                    rushOrderCost = 30;
                }
                else if (totalSurfaceArea >= 100 && totalSurfaceArea <= 2000)
                {
                    rushOrderCost = 35;
                }
                else
                {
                    rushOrderCost = 40;
                }
            }
            else
            {
                rushOrderCost = 0;
            }

            return rushOrderCost;
        }

        public decimal computeDeskSizeCost()
        {
            decimal totalSurfaceArea = computeSurfaceArea(_width, _depth);
            decimal totalDeskSizeCost;
            const decimal BASE_DESK_PRICE = 200;

            if (totalSurfaceArea > 1000)
            {
                totalDeskSizeCost = BASE_DESK_PRICE + (totalSurfaceArea - 1000);
            }
            else
            {
                totalDeskSizeCost = BASE_DESK_PRICE;
            }

            return totalDeskSizeCost;
        }

        public decimal computeDrawerCost()
        {
            return _numberOfDrawer * 50;
        }

        public decimal computeSurfaceMaterialCost()
        {
            decimal surfaceMaterialCost;
            switch (_surfaceMaterial)
            {
                case "Oak":
                    surfaceMaterialCost = 200;
                    break;
                case "Laminate":
                    surfaceMaterialCost = 100;
                    break;
                case "Pine":
                    surfaceMaterialCost = 50;
                    break;
                case "Rosewood":
                    surfaceMaterialCost = 300;
                    break;
                case "Veneer":
                    surfaceMaterialCost = 125;
                    break;
                default:
                    surfaceMaterialCost = 0;
                    break;
            }

            return surfaceMaterialCost;
        }

        public decimal computeDeskPrice()
        {
            decimal totalDeskSizeCost = computeDeskSizeCost();            
            decimal totalDrawerAmount = computeDrawerCost();
            decimal surfaceMaterialCost = computeSurfaceMaterialCost();            
            decimal shippingCost = computeShippingCost();

            return totalDeskSizeCost + totalDrawerAmount + surfaceMaterialCost + shippingCost;
            
        }
    }
}
