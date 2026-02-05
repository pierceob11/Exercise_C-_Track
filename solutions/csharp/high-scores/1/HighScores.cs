using System;
using System.Collections.Generic;

public class HighScores
{
    private List<int> _list;
    
    public HighScores(List<int> list)
    {
        _list = list;
    }

    public List<int> Scores()
    {
        return _list;
    }

    public int Latest()
    {
        return _list[_list.Count - 1];
    }

    public int PersonalBest()
    {
        var copy = new List<int>(_list);
        copy.Sort();
        copy.Reverse();

        int firstItem = copy[0];
        return firstItem;
    }

    public List<int> PersonalTopThree()
    {
        var copy = new List<int>(_list);
        copy.Sort();
        copy.Reverse();

        int loopsComplete = 0;
        var topThree = new List<int>();

        foreach(int score in copy){
            if(loopsComplete < 3){
                topThree.Add(score);
            }
            loopsComplete++;
        }
            return topThree;
        }
        
    }
