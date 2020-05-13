using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReflexOffice.ClientApp.View
{
    /// <summary>
    /// Interaction logic for SettingPage.xaml
    /// </summary>
    public partial class SettingPage : Page
    {
        public SettingPage()
        {
            InitializeComponent();
            loadPrinter();
        }

        void loadPrinter()
        {
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                comboInstalledPrinters.Items.Add(pkInstalledPrinters);
            }
        }

        private void comboInstalledPrinters_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (comboInstalledPrinters.SelectedIndex != -1)
            {
                // The combo box's Text property returns the selected item's text, which is the printer name.
                // printDoc.PrinterSettings.PrinterName = comboInstalledPrinters.Text;
                //properties
                //Settings.PrinterName = comboInstalledPrinters.Text;
            }
        }
    }
}
