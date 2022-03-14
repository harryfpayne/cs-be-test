// Don't edit me
public class Unit
{
    public int Sqft { get; }
    public int Floor { get; }
    
    public Unit(int sqft, int floor) => (Sqft, Floor) = (sqft, floor);
}
class Building {
  public string Name {get;}
  public Unit[] Units {get;}

  /*
    This function is used to compute all possible combinations of units for this building
    The code is crazy, we copied it from somewhere, you don't need to understand it
  */
  public Unit[][] GetAllCombinationsOfUnits() {
    var length = this.Units.Length;
    var subsets = new List<Unit[]>();

    for (var subsetBits = 1; subsetBits < (1 << length); subsetBits ++) {
      var subset = new List<Unit>();
      for (var obj = 0; obj < length; obj++) {
        var i = (subsetBits >> obj)&1;
        if (i == 1) {
          subset.Add(this.Units[obj]);
        }
      }
      Console.WriteLine(subset.Count);
      subsets.Add(subset.ToArray());
    }

    return subsets.ToArray();
  }

  public Building(string name, Unit[] units) => (Name, Units) = (name, units);
}

class CombinationOfFloors {
  
  public string BuildingName {get;}
  public int[] Floors {get;}

  public CombinationOfFloors(string buildingName, int[] floors) => (BuildingName, Floors) = (buildingName, floors);
}

/*
func GetUnitCombinations(units []Unit) [][]Unit {
	length := uint(len(units))
	var subsets [][]Unit

	for subsetBits := 1; subsetBits < (1 << length); subsetBits++ {
		var subset []Unit
		for object := uint(0); object < length; object++ {
			if (subsetBits>>object)&1 == 1 {
				subset = append(subset, units[object])
			}
		}
		subsets = append(subsets, subset)
	}
	return subsets
}
*/