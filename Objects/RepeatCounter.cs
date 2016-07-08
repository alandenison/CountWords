using System;
using System.Collections.Generic;

namespace Counter.Objects
{
  public class RepeatCounter
  {
    public string _inputSentence;
    public string _inputSearch;

    public RepeatCounter(string inputSentence, string inputSearch)
    {
      _inputSentence = inputSentence;
      _inputSearch = inputSearch;
    }
    public void SetSentence(string newSentence)
    {
      _inputSentence = newSentence;
    }
    public string GetSentence()
    {
      return _inputSentence;
    }
    public void SetSearch(string newSearch)
    {
      _inputSearch = newSearch;
    }
    public string GetSearch()
    {
      return _inputSearch;
    }


    public int CountRepeats()
    {
      string sentence = _inputSentence.ToLower();
      int sentenceCount = sentence.Length;
      int afterLength = sentence.Replace(_inputSearch, "").Length;
      return (sentenceCount-afterLength)/_inputSearch.Length;
    }
  }
}
