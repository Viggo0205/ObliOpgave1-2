using ObligatoriskOpg1_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TrophyRepository
{

    private List<Trophy> trophys = new List<Trophy>();

    private int _nextid;

    public TrophyRepository() { }

    public List<Trophy> Read(int? year = null, string? comp = null)
    {
        List<Trophy> result = new List<Trophy>(trophys);

        if (year != null)
        {
            result = result.FindAll(t => t.Year >= year).ToList();
        }

        if (comp != null)
        {
            result = result.FindAll(t => t.Competition == comp).ToList();
        }

        return result;

    }

    public Trophy GetTrophy(int id)
    {
        return trophys.FirstOrDefault(t => t.Id == id);
    }

    public Trophy AddTrophy(Trophy trophy)
    {
        trophy.Validate();
        trophy.Id = _nextid++;
        trophys.Add(trophy);
        return trophy;
    }

    public Trophy? DeleteTrophy(int id)
    {
        trophys.Remove(GetTrophy(id));
        return GetTrophy(id);
    }

    public Trophy? UpdateTrophy(int id, Trophy UpdatedTrophy)
    {
        UpdatedTrophy.Validate();
        Trophy exsisting = GetTrophy(id);
        if (exsisting == null)
        {
            return null;
        }
        exsisting.Competition = UpdatedTrophy.Competition;
        exsisting.Year = UpdatedTrophy.Year;
        return exsisting;
    }


}

