module aws.tests

open NUnit.Framework
open Aws

[<SetUp>]
let Setup () =
    ()

[<Test>]
let TwoGroupsWithTwoAndThreeElementsInARowShouldReturnNineGroups () =
    let input = [|4;3;5;4;3|]
    let res = Calc.countDecreasingRatings input  
    Assert.AreEqual(9, res) 



[<Test>]
let TwoGroupsWithTwoAndThreeElementsDividedShouldReturnTenGroups () =
    let input = [|4;3;3;5;4;3|]
    let res = Calc.countDecreasingRatings input  
    Assert.AreEqual(10, res) 


[<Test>]
let OneGroupWith6ElementsReturnTwentyOneGroups () =
    let input = [|6;5;4;3;2;1|]
    let res = Calc.countDecreasingRatings input  
    Assert.AreEqual(21, res) 

