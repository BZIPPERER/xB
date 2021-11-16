﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel; // 100 / 15 ?
using System.Windows;
using System.Windows.Data;

namespace xBalsat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> person;  
        public MainWindow()
        {
            InitializeComponent();
            person = new ObservableCollection<Person>()  
            {  
             new Person(){Name="Sukhit Prabhat",Address="India"},  
  
             new Person(){Name="Adrian Smith",Address="US"} ,

             new Person(){Name="Benjamin Zipperer",Address="Germany"},

             new Person(){Name="James Fuller", Address="UK"}

            };  
            lstNames.ItemsSource = person;

         
			 
        }

        // ButtonEvent
         private void btnNames_Click(object sender, RoutedEventArgs e)  
        {  
         person.Add(new Person() { Name = txtName.Text, Address = txtAddress.Text });  
         txtName.Text = string.Empty;  
         txtAddress.Text = string.Empty;  
        }  
    }
}
