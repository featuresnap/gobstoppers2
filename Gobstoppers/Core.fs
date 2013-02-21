module Core

type Color = Yellow|Red|Blue|Purple|Green
type Shape = Ring|Ball|Cube|Plus|Spring
type Gobstopper = Color * Shape

let makeGobstopper (raw:string) = 
    let makeColor = function 
        |'Y' |'y' -> Yellow
        |'R' |'r' -> Red
        |'B' |'b' -> Blue
        |'P' |'p' -> Purple
        |'G' |'g' -> Green
        |_ -> failwith "Bad color"
    let makeShape = function
        |'R' |'r' -> Ring
        |'B' |'b' -> Ball
        |'C' |'c' -> Cube
        |'P' |'p' -> Plus
        |'S' |'s' -> Spring
        |_ -> failwith "Bad shape"

    let (c,s) = (raw.[0], raw.[1])
    (makeColor c, makeShape s)


