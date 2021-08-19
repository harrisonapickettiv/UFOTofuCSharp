using System.Text.RegularExpressions;

namespace UFOTofu.Models {
  public class Palindrome {
    private string _inputWord = "";
    private string _revWord = "";

    private string cleanWord(string word) {
      return Regex.Replace(word.ToLower(), "[^a-zA-Z0-9]+", "");
    }
    private string reverse(string word) {
      string revWord = "";
      for( int i = 0; i < word.Length; i++) {
        revWord = word[i] + revWord;
      }
      return revWord;
    }

    public string InputWord {
      get {
        return _inputWord;
      }
      set {
        _inputWord = (value != null) ? value : "";
        _revWord = reverse(_inputWord);
      }
    }
    public string RevWord {
      get {
        return _revWord;
      }
    }
    public bool isPalindrome {
      get {
        return cleanWord(_inputWord) == cleanWord(_revWord);
      }
    }
    public string Message {
      get {
        if (_inputWord == "") { return ""; }
        return ( isPalindrome ) 
          ? $"Success! {_inputWord} is a Palindrome!"
          : $"Sorry, {_inputWord} is not a Palindrome.";
      }
    }
  }
}