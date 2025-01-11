// https://atcoder.jp/contests/abc028/tasks/abc028_a

let run n =
    if n = 100 then
        "Perfect"
    elif n >= 90 then
        "Graet"
    elif n >= 60 then
        "Good"
    else
        "Bad"

printfn "%s" (run 80)
//=> Good

printfn "%s" (run 100)
//=> Perfect

printfn "%s" (run 59)
//=> Bad

printfn "%s" (run 95)
//=> Great
