/**********************************************************************
 * Project:     PR 10b - Morse Code
 * File:        Decoder Node
 * Language:    C#
 * 
 * Description: This is the decoder node for the Morse code program
 * 
 *  College:    Husson University
 *  Course:     IT 326
 *  
 *  Edit History
 *  Ver: Who: Date:     Notes
 *  ---  ---  --------   -----------------------------------------------
 *  0.1  MLF  3/12/24  - initial writing
 *                     - added the properties and constructor to set up 
 *                       the node for the morse code decoder
 **********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flewelling_Mitchell_PR_10b___Morse_Code
{
    internal class MorseCodeDecoderNode
    {
        #region data
        #endregion data

        #region properties
        public string MorseCode { get; set; } // the Morse code
        public char Character { get; set; } // the character
        public MorseCodeDecoderNode Left { get; set; } // the left node
        public MorseCodeDecoderNode Right { get; set; } // the right node
        #endregion properties

        #region constructor
        /// <summary>
        /// This constructor will create a new Morse code decoder node
        /// </summary>
        /// <param name="morseCode">the morse code associated with the character</param>
        /// <param name="character">the character represented by the morse code</param>
        public MorseCodeDecoderNode(string morseCode, char character)
        {
            MorseCode = morseCode;
            Character = character;
            Left = null;
            Right = null;
        }
        #endregion constructor

        #region events
        #endregion events

        #region methods
        #endregion methods
    }
}
