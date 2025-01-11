// https://atcoder.jp/contests/abc035/tasks/abc035_a

let run w h =
    if h*4 = w*3 then
        "4:3"
    else
        "16:9"

printfn "%s" (run 4 3)
//=> 4:3

printfn "%s" (run 16 9)
//=> 16:9

printfn "%s" (run 28 21)
//=> 4:3
