using System;
using System.Collections.Generic;

namespace Counter.Objects
{
  public class RepeatCounter
  {
    private string _inputSentence;
    private string _inputSearch;

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
      string search = _inputSearch.ToLower();
      int sentenceCount = sentence.Length;
      int afterLength = sentence.Replace(search, "").Length;
      return (sentenceCount-afterLength)/search.Length;
    }
  }
}
