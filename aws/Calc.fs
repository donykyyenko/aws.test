// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
namespace Aws 

open System
open FSharp.Core
open FSharp.Collections

module Calc =
    let countDecreasingRatings (ratings: int[]) : int =
        let accumulator n = n*(n+1)/2 
        let (res, lastN, _) = ratings |> Array.fold (fun (totalGroups, n, prev) current ->
                 if prev <= current then totalGroups + accumulator n, 1, current else totalGroups, n+1, current) (0,0,0)
        res + accumulator lastN    
            
                            
                           
          
        



          


