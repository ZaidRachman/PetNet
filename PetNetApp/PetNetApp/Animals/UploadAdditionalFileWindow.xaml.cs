﻿using DataObjects;
using LogicLayer;
using Microsoft.Win32;
using System;
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

namespace WpfPresentation.Animals
{
    /// <summary>
    /// Interaction logic for UploadAdditionalFileWindowNew.xaml
    /// </summary>
    public partial class UploadAdditionalFileWindow : Window
    {
        private Animal _animal = null;
        private MasterManager _manager = MasterManager.GetMasterManager();
        private bool _imageSelected = false;
        private OpenFileDialog _fileDialog = new OpenFileDialog();

        public UploadAdditionalFileWindow(Animal animal, MasterManager masterManager)
        {
            _animal = animal;
            _manager = masterManager;
            InitializeComponent();
        }

        private void btnBrowseFiles_Click(object sender, RoutedEventArgs e)
        {
            _fileDialog.Filter = "Images|*.png;*.jpg;*.gif;*.jpeg;*.tiff;*.tif;*.webp;*.wav;*.bmp;*.exif";
            _fileDialog.Multiselect = true;

            _imageSelected = _fileDialog.ShowDialog() == true;
            if (_imageSelected == true)
            {
                try
                {
                    imgSelectedImage.Source = new BitmapImage(new Uri(_fileDialog.FileName));
                    string filename = _fileDialog.SafeFileName;
                    txtFileUpload.Text = filename;
                }
                catch
                {
                    PromptWindow.ShowPrompt("Error", "Not a valid image");
                }
            }
            else
            {
                txtFileUpload.Text = "";
                imgSelectedImage.Source = null;
            }
        }

        private void btnCancelUpload_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUploadFile_Click(object sender, RoutedEventArgs e)
        {
            if (_imageSelected)
            {
                try
                {
                    if (_fileDialog.SafeFileNames.Length > 1)
                    {
                        _manager.ImageManager.AddMedicalImagesByAnimalId(_animal.AnimalId, _fileDialog.FileNames);
                        PromptWindow.ShowPrompt("Success", "Images Added");
                    }
                    else
                    {
                        _manager.ImageManager.AddMedicalImageByAnimalId(_animal.AnimalId, _fileDialog.FileName);
                        PromptWindow.ShowPrompt("Success", "Image Added");
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    PromptWindow.ShowPrompt("Error", ex.Message);
                }
            }
            else
            {
                PromptWindow.ShowPrompt("Sorry", "Please select an image first");
            }
        }
    }
}
