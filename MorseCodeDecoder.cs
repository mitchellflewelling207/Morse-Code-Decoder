/**********************************************************************
 * Project:     PR 10b - Morse Code
 * File:        Decoder using a Binary Search Tree
 * Language:    C#
 * 
 * Description: This is a class that will represent a morse code decoder
 *              using a binary search tree.
 *              
 *  College:    Husson University
 *  Course:     IT 326
 *  
 *  Edit History
 *  Ver: Who: Date:     Notes
 *  ---  ---  --------   -----------------------------------------------
 *  0.1  MLF  3/12/24  - initial writing
 *                     - implemented a method to add mappings to the tree
 *                     - implemented a method to decode a message
 **********************************************************************/
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flewelling_Mitchell_PR_10b___Morse_Code
{
    internal class MorseCodeDecoder
    {
        #region data
        private MorseCodeDecoderNode root; // the root of the tree
        #endregion data

        #region properties
        #endregion properties

        #region constructor
        public MorseCodeDecoder()
        {
            root = new MorseCodeDecoderNode("/", ' '); // create the root node

            // add the morse code mappings
            AddMapping('A', ".-");
            AddMapping('B', "-...");
            AddMapping('C', "-.-.");
            AddMapping('D', "-..");
            AddMapping('E', ".");
            AddMapping('F', "..-.");
            AddMapping('G', "--.");
            AddMapping('H', "....");
            AddMapping('I', "..");
            AddMapping('J', ".---");
            AddMapping('K', "-.-");
            AddMapping('L', ".-..");
            AddMapping('M', "--");
            AddMapping('N', "-.");
            AddMapping('O', "---");
            AddMapping('P', ".--.");
            AddMapping('Q', "--.-");
            AddMapping('R', ".-.");
            AddMapping('S', "...");
            AddMapping('T', "-");
            AddMapping('U', "..-");
            AddMapping('V', "...-");
            AddMapping('W', ".--");
            AddMapping('X', "-..-");
            AddMapping('Y', "-.--");
            AddMapping('Z', "--..");
            AddMapping('1', ".----");
            AddMapping('2', "..---");
            AddMapping('3', "...--");
            AddMapping('4', "....-");
            AddMapping('5', ".....");
            AddMapping('6', "-....");
            AddMapping('7', "--...");   
            AddMapping('8', "---..");
            AddMapping('9', "----.");
            AddMapping('0', "-----");
        }
        #endregion constructor

        #region events
        #endregion events

        #region methods
        /// <summary>
        /// This method will add a mapping between a character and its 
        /// Morse code representation in the binary search tree
        /// </summary>
        /// <param name="character">the character to be mapped</param>
        /// <param name="morseCode">the morse code representation of the character.</param>
        private void AddMapping(char character, string morseCode)
        {
            // start at the root
            MorseCodeDecoderNode current = root;

            // traverse through each character in the morse code
            foreach (char morseSymbol in morseCode)
            {
                // if the morse symbol is a dot, go left
                if (morseSymbol == '.')
                {
                    // if the left node is null, create a new node
                    if (current.Left == null)
                    {
                        current.Left = new MorseCodeDecoderNode("/", ' ');
                    }
                    current = current.Left; // move to the left node
                }
                // if the morse symbol is a dash, go right
                else if (morseSymbol == '-')
                {
                    // if the right node is null, create a new node
                    if (current.Right == null)
                    {
                        current.Right = new MorseCodeDecoderNode("/", ' ');
                    }
                    current = current.Right; // move to the right node
                }
            }

            current.Character = character; // set the character
        }

        /// <summary>
        /// Decodes an encoded message using the binary search tree
        /// </summary>
        /// <param name="encodedMessage">The encoded message to decode</param>
        /// <returns>The decoded message</returns>
        public string Decode(string encodedMessage)
        {
            // use a string builder to build the decoded message
            StringBuilder decodedMessage = new StringBuilder();

            // start at the root
            MorseCodeDecoderNode current = root; 

           // traverse through each character in the encoded message
            foreach (char morseSymbol in encodedMessage)
            {
                // if the morse symbol is a dot, go left
                if (morseSymbol == '.')
                {
                    current = current.Left; // move to the left node
                }
                // if the morse symbol is a dash, go right
                else if (morseSymbol == '-')
                {
                    current = current.Right; // move to the right node
                }
                // if the morse symbol is a space, add the character to the decoded message
                else if (morseSymbol == ' ')
                {
                    decodedMessage.Append(current.Character);
                    // start at the root again
                    current = root;
                }
                else
                {
                   // handle the case where the morse symbol is not a dot, 
                   // dash, or space, just print out the original messasge 
                   decodedMessage.Append(morseSymbol);
                }
            }

            // return the decoded message
            return decodedMessage.ToString();
        }
        #endregion methods
    }
}
