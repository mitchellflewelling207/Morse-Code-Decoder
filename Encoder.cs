/**********************************************************************
 * Project:     PR 10b - Morse Code
 * File:        Encoder using a Hash Table
 * Language:    C#
 * 
 * Description: This file is the encoder class for the Morse code program
 *              I will use a hash table to encode a message into Morse code.
 *              
 *  College:    Husson University
 *  Course:     IT 326
 *  
 *  Edit History
 *  Ver: Who: Date:     Notes
 *  ---  ---  --------   -----------------------------------------------
 *  0.1  MLF  3/12/24  - initial writing
 *                     - implemented a method to initialize the mappings
 *                     - implemented a method to encode a message
 *                     - added all appropriate data and constructors
 **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flewelling_Mitchell_PR_10b___Morse_Code
{
    internal class Encoder
    {
        #region data
        private const int TABLE_SIZE = 128; // the size of the table
        private readonly string[] table; // the table
        #endregion data

        #region properties
      
        #endregion properties

        #region constructor
        /// <summary>
        /// This constructor will create a new hash table 
        /// for the encoder.
        /// </summary>
        public Encoder()
        {
            table = new string[TABLE_SIZE]; // create the table
            InitializeMappings(); // initialize the mappings
        }
      
        #endregion constructor

        #region events
        #endregion events

        #region methods

        /// <summary>
        /// This method initializes the mappings for the encoder
        /// </summary>
        private void InitializeMappings()
        {
            // initialize mappings for each character
            table['A'] = ".-";
            table['B'] = "-...";
            table['C'] = "-.-.";
            table['D'] = "-..";
            table['E'] = ".";
            table['F'] = "..-.";
            table['G'] = "--.";
            table['H'] = "....";
            table['I'] = "..";
            table['J'] = ".---";
            table['K'] = "-.-";
            table['L'] = ".-..";
            table['M'] = "--";
            table['N'] = "-.";
            table['O'] = "---";
            table['P'] = ".--.";
            table['Q'] = "--.-";
            table['R'] = ".-.";
            table['S'] = "...";
            table['T'] = "-";
            table['U'] = "..-";
            table['V'] = "...-";
            table['W'] = ".--";
            table['X'] = "-..-";
            table['Y'] = "-.--";
            table['Z'] = "--..";
            table['1'] = ".----";
            table['2'] = "..---";
            table['3'] = "...--";
            table['4'] = "....-";
            table['5'] = ".....";
            table['6'] = "-....";
            table['7'] = "--...";
            table['8'] = "---..";
            table['9'] = "----.";
            table['0'] = "-----";
        }

        /// <summary>
        /// This method will encode a message into Morse code
        /// </summary>
        /// <param name="message">The message to be encoded</param>
        /// <returns>An encoded message</returns>
        public string Encode(string message)
        {
            // create a new string builder
            StringBuilder encodedMessage = new StringBuilder(); 

            // loop through each character in the message
            foreach (char mySymbol in message.ToUpper())
            {
                // if the character is in the table, add it to the encoded message
                if (mySymbol >= 0 && mySymbol < TABLE_SIZE && table[mySymbol] != null)
                {
                    encodedMessage.Append(table[mySymbol]);
                    encodedMessage.Append(" ");
                }
                // if the character is not in the table, add a space
                else
                {
                    encodedMessage.Append(mySymbol);
                    encodedMessage.Append(" ");
                }
            }

            // return the encoded message
            return encodedMessage.ToString();
        }
        #endregion methods 
    }
}
