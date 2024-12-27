// https://atcoder.jp/contests/abc030/tasks/abc030_a

let run a b c d =
    let ta = float b / float a
    let ao = float d / float c

    if ta > ao then
        "TAKAHASHI"
    elif ta < ao then
        "AOKI"
    else
        "DRAW"

printfn "%s" (run 5 2 6 3)
//=> AOKI

printfn "%s" (run 100 80 100 73)
//=> TAKAHAASHI

printfn "%s" (run 66 30 55 25)
//=> DRAW
