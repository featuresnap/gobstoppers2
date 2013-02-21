module CoreTest

open NUnit.Framework
open FsUnit
open Core

[<TestFixture>]
type ``Given a way to make Gobstoppers`` () = 
    let sut = makeGobstopper

    [<Test>] member test.
     ``It combines the color and the shape`` () = 
        (sut "yB") |> should equal (Yellow, Ball)

    [<Test>] [<ExpectedException>] member test.
     ``It throws if the color is undefined`` () = 
        (sut "zB") |> ignore |> should throw typeof<System.Exception>

    [<Test>] [<ExpectedException>] member test.
     ``It throws if the shape is undefined`` () = 
        (sut "yz") |> ignore |> should throw typeof<System.Exception>




    



