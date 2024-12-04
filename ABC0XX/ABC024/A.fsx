// https://atcoder.jp/contests/abc024/tasks/abc024_a

let run a b c k s t =
    let child = a * s
    let adult = b * t

    if s + t >= k then
        child + adult - (s + t) * c
    else
        child + adult

printfn "%i" (run 100 200 50 20 40 10)
//=> 3500

printfn "%i" (run 400 1000 400 21 10 10)
//=> 14000

printfn "%i" (run 400 1000 400 20 10 10)
//=> 6000
