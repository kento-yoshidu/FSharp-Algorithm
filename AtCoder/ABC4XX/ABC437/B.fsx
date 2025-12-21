// https://atcoder.jp/contests/abc437/tasks/abc437_b

let fn _h _w _n a b =
    a
    |> Array.map (fun v ->
        v
        |> Array.filter (fun num -> b |> Array.contains num)
        |> Array.length)
    |> Array.max


printfn "%i" (fn 3 4 5 [| [| 12; 3; 5; 7 |]; [| 6; 10; 11; 9 |]; [| 1; 2; 4; 8 |] |] [| 2; 4; 9; 6; 11 |])
//=> 3

printfn "%i" (fn 3 5 2 [| [| 81; 63; 31; 16; 15 |]; [| 30; 3; 6; 54; 24 |]; [| 26; 41; 48; 64; 66 |] |] [| 44; 79 |])
//=> 0

printfn "%i" (fn 3 5 12 [| [| 78; 19; 70; 58; 83 |]; [| 12; 30; 80; 20; 27 |]; [| 48; 71; 8 ;43; 82 |] |] [| 82; 30; 43; 8; 80; 70; 20; 78; 12; 71; 19; 48 |])
//=> 5
