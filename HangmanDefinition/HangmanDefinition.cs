using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace HangmanDefinition
{
    public partial class HangmanDefinition : Form
    {
        const int MAX_GUESSES = 5;

        bool _isGameOver;
        int _guessesLeft;
        List<string> _wordList = new List<string>();
        string _currentWordAndDefinition;
        string _currentWord;
        string _currentDefinition;

        public HangmanDefinition()
        {
            InitializeComponent();
            ReadWordFile();
        }

        void PickRandomWord()
        {
            // pick a random element in the list
            int wordIndex = new Random().Next(_wordList.Count);
            _currentWordAndDefinition = _wordList[wordIndex];

            // split the element to extract the word and its definition
            string[] currentWordAndDefinitionSplit = _currentWordAndDefinition.Split('/');
            _currentWord = currentWordAndDefinitionSplit[0].Trim();
            _currentDefinition = currentWordAndDefinitionSplit[1].Trim();

            // update the definition label with the selected definition
            labelDefinition.Text = _currentDefinition;
        }

        void ReadWordFile()
        {
            // read the "words.txt" file and store the lines in a list
            if (File.Exists("words.txt"))
                _wordList.AddRange(File.ReadAllLines("words.txt"));
            else
                MessageBox.Show("The file \"words.txt\" couldn't be found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // make sure buttons are enabled only if the list is not empty
            buttonGuess.Enabled = _wordList.Count != 0;
            buttonNextWord.Enabled = _wordList.Count != 0;
        }

        private void UpdateAvailableWordsLabel()
        {
            // update available words label with the current number of available words
            labelAvailableWords.Text = $"Available words: { _wordList.Count - 1 }";
        }

        private void UpdateGuessesLeftLabel()
        {
            // update guesses left label with the current number of guesses left
            labelGuessesLeft.Text = $"Guesses left: { _guessesLeft }";
        }

        // event handlers
        private void ButtonGuess_Click(object sender, EventArgs e)
        {
            _isGameOver = textBoxWord.Text.Trim().ToLower() == _currentWord.ToLower();

            // correct guess
            if (_isGameOver)
            {
                // play a success sound
                SystemSounds.Asterisk.Play();
            }
            // incorrect guess
            else
            {
                // play an error sound
                SystemSounds.Hand.Play();

                // decrease the counter of guesses left
                _guessesLeft--;
                UpdateGuessesLeftLabel();

                // no more guesses left, game is over
                _isGameOver = _guessesLeft == 0;

                if (_isGameOver)
                    textBoxWord.Text = _currentWord;
            }

            // game is over, disable Guess button
            buttonGuess.Enabled = !_isGameOver;
        }

        private void ButtonNextWord_Click(object sender, EventArgs e)
        {
            // remove current word from the list
            if (checkBoxRemovePreviousWords.Checked)
            {
                _wordList.Remove(_currentWordAndDefinition);
                UpdateAvailableWordsLabel();
            }

            // reset variables to their default state
            _isGameOver = false;
            _guessesLeft = MAX_GUESSES;
            _currentWordAndDefinition = String.Empty;
            _currentWord = String.Empty;
            _currentDefinition = String.Empty;
            UpdateGuessesLeftLabel();

            // pick a random word
            PickRandomWord();

            // reset word textbox
            textBoxWord.Text = String.Empty;
            textBoxWord.Focus();

            // disable buttons
            buttonNextWord.Enabled = _wordList.Count > 1;
            buttonGuess.Enabled = _wordList.Count > 0 && textBoxWord.Text != string.Empty;
        }

        private void HangmanDefinition_Load(object sender, EventArgs e)
        {
            buttonNextWord.PerformClick();
        }

        private void TextBoxWord_TextChanged(object sender, EventArgs e)
        {
            buttonGuess.Enabled = textBoxWord.Text != string.Empty;
        }
    }
}
