// https://atcoder.jp/contests/abc365/tasks/abc365_a

let fn y =
    if y % 4 <> 0 then
        365
    elif y % 100 <> 0 then
        366
    elif y % 400 <> 0 then
        365
    else
        366

printfn "%i" (fn 2023)
//=> 365

printfn "%i" (fn 1992)
//=> 366

printfn "%i" (fn 1800)
//=> 365

printfn "%i" (fn 1600)
//=> 366
