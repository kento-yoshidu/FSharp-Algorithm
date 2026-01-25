// https://atcoder.jp/contests/abc442/tasks/abc442_b

let fn _q (a: int array) =
    a
    |> Array.scan (fun (v, b) (x: int) ->
        match x with
        | 1 -> v + 1, b
        | 2 -> (if v >= 1 then v - 1 else v), b
        | 3 -> v, not b
        | _ -> failwith "unreachable"
    ) (0, false)
    |> Array.skip 1
    |> Array.map (fun (v, b) ->
        if b && v >= 3 then "Yes" else "No"
    )

printfn "%A" (fn 10 [| 2; 1; 3; 1; 3; 1; 1; 3; 2; 2 |])
//=> [|"No"; "No"; "No"; "No"; "No"; "No"; "No"; "Yes"; "Yes"; "No"|]
