/**********************************************************************
 * Project:     PR 10b - Morse Code
 * File:        Morse Code Main Form
 * Language:    C#
 * 
 * Description: This is the main form for the Morse code program
 *              demonstrating how to decode and encode Morse code using
 *              data from a file. 
 *              
 *  College:    Husson University
 *  Course:     IT 326
 *  
 *  Edit History
 *  Ver: Who: Date:     Notes
 *  ---  ---  --------   -----------------------------------------------
 *  0.1  MLF  3/12/24  - initial writing
 *                     - added the GetFileName method
 *                     - added a method to process a file
 *                     - hooked up all buttons to their respective events
 *  0.2  MLF  3/13/24  - cleaned up the code
 *                     - reworked the ProcessFile method
 **********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flewelling_Mitchell_PR_10b___Morse_Code
{
    public partial class FormMorseCode : Form
    {
        #region data
        private MorseCodeDecoder decoder; // the decoder
        private Encoder encoder; // the encoder
        #endregion data

        #region properties
        #endregion properties

        #region constructor
        /// <summary>
        /// This constructor will create a new form for the Morse code program
        /// </summary>
        public FormMorseCode()
        {
            InitializeComponent();
            decoder = new MorseCodeDecoder();
            encoder = new Encoder();
        }
        #endregion constructor

        #region events
        /// <summary>
        /// This button will clear all three list boxes when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clear the list boxes 
            listBoxOriginalMessage.Items.Clear();
            listBoxEncodedMessage.Items.Clear();
            listBoxDecodedMessage.Items.Clear();
        }

        /// <summary>
        /// This event will open a file dialog and allow the user 
        /// to process a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFile_Click(object sender, EventArgs e)
        {
            // get the file name
            string filename = GetFileName();

            // process the file
            if (!string.IsNullOrEmpty(filename))
            {
                ProcessFile(filename);
            }
        }

        /// <summary>
        /// This button will process the user's input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            // get the user's input
            string userInput = textBoxInput.Text;

            // encode the message
            string encodedMessage = encoder.Encode(userInput);
            listBoxEncodedMessage.Items.Add(encodedMessage);

            // decode the message
            string decodedMessage = decoder.Decode(encodedMessage);
            listBoxDecodedMessage.Items.Add(decodedMessage);

            // display the original message
            listBoxOriginalMessage.Items.Add(userInput);
        }
        #endregion events

        #region methods
        /// <summary>
        /// This method will open a file dialog and allow the user
        /// to select a single file. 
        /// </summary>
        /// <returns>full path of the seleected file, 
        /// or string.empty if no file was selected</returns>
        public string GetFileName()
        {
            // short syntax to open file dialog
            OpenFileDialog myFileDialog = new OpenFileDialog();

            // set the filename defaultly to empty
            string filename = string.Empty;

            // set up the dialog box
            myFileDialog.InitialDirectory = 
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            myFileDialog.RestoreDirectory = true;
            myFileDialog.Title = "Select a file";
            myFileDialog.DefaultExt = "txt";
            myFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            myFileDialog.FilterIndex = 1;

            // show the dialog box
            if (myFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = myFileDialog.FileName;

                MessageBox.Show(filename);
            }

            // return the file's name
            return filename;
        }

        /// <summary>
        /// This method will process a file passed in by the user
        /// </summary>
        /// <param name="filename">The file passed in</param>
        public void ProcessFile(string filename)
        {
            string line; // a line from the file
            StreamReader reader = null; // the stream reader
            string encodedMessage; // the encoded message
            string decodedMessage; // the decoded message

            try
            {
                // create a new stream reader
                reader = new StreamReader(filename);

                // read each line from the file
                while ((line = reader.ReadLine()) != null)
                {
                    // encode the message
                    encodedMessage = encoder.Encode(line);
                    listBoxEncodedMessage.Items.Add(encodedMessage);

                    // decode the message
                    decodedMessage = decoder.Decode(encodedMessage);
                    listBoxDecodedMessage.Items.Add(decodedMessage);

                    // display the original message
                    listBoxOriginalMessage.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close the reader
                if (reader != null)
                {
                    reader.Close();
                }
            }

        }
        #endregion methods
    }
}
