using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DxGridLookupExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<Car> Cars = new List<Car>();
        List<Color> Colors;
        List<ColorMarka> ColoryDlaMarki;

        public Form1()
        {
            InitializeComponent();

            


            Colors = CreateColors();
            ColoryDlaMarki = CreateKoloryDlaMarki();

            bsCars.DataSource = Cars;
            bsColors.DataSource = Colors;
        }

        private List<Color> CreateColors()
        {
            return new List<Color>()
            {
                new Color { Id = 1, Name = "Czerwony" },
                new Color { Id = 2, Name = "Zielony" },
                new Color { Id = 3, Name = "Zółty" },
                new Color { Id = 4, Name = "Czarny" }
            };
        }
        private List<ColorMarka> CreateKoloryDlaMarki()
        {
            return new List<ColorMarka> {
                new ColorMarka { Marka="Fiat", ColorId = 1},
                new ColorMarka { Marka="Fiat", ColorId = 2},
                new ColorMarka { Marka="Fiat", ColorId = 3},
                new ColorMarka { Marka="BMW", ColorId = 3},
                new ColorMarka { Marka="BMW", ColorId = 4},
                
            };
        }
        private List<Color> GetColorsForMarka(string marka)
        {
            // pobranie kolorów dostępnych dla marki po nazwie marki, jakieś zapytanie dl DB
            var colorIds = ColoryDlaMarki.Where(x => x.Marka == marka).Select(x => x.ColorId).ToList();
            return Colors.Where(x => colorIds.Contains(x.Id)).ToList();
        }

        private void repColors_QueryPopUp(object sender, CancelEventArgs e)
        {
            // filtrowanie dostępnych kolorów wg zawartośći pola Marka

            string marka = (string)gvCars.GetRowCellValue(gvCars.FocusedRowHandle, colMarka);
            //jeśli nie ma wpisanej marki to nic nie pokazujemy
            if (string.IsNullOrEmpty(marka))
                e.Cancel = true;

            bsColors.DataSource = GetColorsForMarka(marka);
        }

        private void repColors_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            //załadowanie WSZYSTKICH kolorów po zamknięciu listy kolorów
            bsColors.DataSource = Colors;
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Opis { get; set; }
        public int ColorId { get; set; }
    }

    public class ColorMarka
    {
        public string Marka { get; set; }
        public int ColorId { get; set; }
    }

    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
