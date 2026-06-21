// https://atcoder.jp/contests/abc383/tasks/abc383_a

let fn _n tv =
    tv
    |> Array.fold (fun (prevT, cur) (t, v) ->
        let newCur =
            if prevT = -1 then
                v
            else
                max 0 (cur - (t - prevT)) + v

        t, newCur

    ) (-1, 0)
    |> snd

printfn "%i" (fn 4 [|(1, 3); (3, 1); (4, 4); (7, 1)|])
//=> 3

printfn "%i" (fn 3 [| (1, 8); (10, 11); (21, 5) |])
//=> 5

printfn "%i" (fn 10 [| (2, 1); (22, 10); (26, 17); (29, 2); (45, 20); (47, 32); (72, 12); (75, 1); (81, 31); (97, 7) |])
//=> 57
