// https://atcoder.jp/contests/abc449/tasks/abc449_a

let fn d =
    let r = d / 2.0

    r * r * System.Math.PI

printfn "%f" (fn 2)
//=> 3.141593

printfn "%f" (fn 7)
//=> 38.484510

printfn "%f" (fn 98)
//=> 7542.963961
