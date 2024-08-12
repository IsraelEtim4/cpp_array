// using System.Text;

// CRUD ARRAY
// Create
string[] favoriteInstruments = ["Double Bass", "Bass Guitar", "Harp", "Acoustic Guitar", "Cello"];

// Read : This Console pattern will not work
Console.WriteLine(favoriteInstruments);
// If you want to read things in array, you'll need to iterate through. Same concepts that has to do with collections
// foreach (var item in favoriteInstruments)
// {
//   Console.WriteLine(item);
// }

// Update: old school way is using bracket to reaching and changing what we want.
favoriteInstruments[0] = "Semiacoustic Viola";
// foreach (var item in favoriteInstruments)
// {
//   Console.WriteLine(item);
// }
// Better way of updating is using LINQ. For example, If you want to get anything that starts with the B, you will write
// LINQ - "filter array linq" or "update array linq" Better still, use any infinte combination followed by linq
// Note: when you type a linq statement, you'll need to use var because linq statement when combined with SQL can change your runtime
var newFavoriteInstrument = favoriteInstruments.Where((e) => e.StartsWith("B"));
foreach (var item in newFavoriteInstrument)
{
  Console.WriteLine(item);
}

// Delete
// I actually haven't used this before so, i'll not teach yah!