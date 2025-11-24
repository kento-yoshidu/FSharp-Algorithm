// https://atcoder.jp/contests/joi2026yo1b/tasks/joi2026_yo1b_c

let fn n s =
    s
    |> Seq.windowed 3
    |> Seq.filter (fun win ->
        win = [| 'A'; 'O'; 'I' |] || win = [| 'I'; 'O'; 'I' |])
    |> Seq.length

printfn "%i" (fn 5 "IAOIO")
//=> 1

printfn "%i" (fn 8 "AOIOIOIA")
//=> 3

printfn "%i" (fn 6 "IIOOII")
//=> 0

printfn "%i" (fn 15 "IAOIAOAOIOIAIOI")
//=> 4
