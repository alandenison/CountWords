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
      return ((_inputSentence.Replace(" ", "").Length) - ((" " + _inputSentence.ToLower().Replace(" ", "  ") + " ")).Replace((" " + _inputSearch.ToLower() + " "), "").Replace(" ", "").Length)/_inputSearch.Length;
    }
  }
}
