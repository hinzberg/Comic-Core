﻿using CCore.Data;
using System.Windows;

namespace CCore.Windows
{
    public partial class PublisherEditWindow : Window
    {
        private Publisher publisher;

        public PublisherEditWindow(WindowOpenMode openMode, Publisher publisher)
        {
            InitializeComponent();
            this.publisher = publisher;
            if (openMode == WindowOpenMode.EditData)
            {
                this.UpdateView();
            }
        }

        private void UpdateView()
        {
            this.guidTextBlock.Text = this.publisher.Id.ToString();
            this.publisherNameTextBox.Text = this.publisher.PublisherName;
        }

        private void UpdateModel()
        {
            this.publisher.PublisherName = this.publisherNameTextBox.Text.Trim();
        }

        private void OnOkButtonClick(object sender, RoutedEventArgs e)
        {
            this.UpdateModel();
            this.DialogResult = true;
        }

        private void OnCancelButtonClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
