// https://atcoder.jp/contests/abc206/tasks/abc206_a

let fn n =
    let p = int (floor (float n) * 1.08)

    if p = 206 then
        "so-so"
    else if p < 206 then
        "Yay!"
    else
        ":("

printfn "%s" (fn 180)
//=> Yay!

printfn "%s" (fn 200)
//=> :(

printfn "%s" (fn 191)
//=> so-so
