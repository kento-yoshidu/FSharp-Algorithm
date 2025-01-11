// https://atcoder.jp/contests/arc146/tasks/arc146_a

let rec permutations (lst: 'a list) (n: int): 'a list list =
    if n = 0 then [[]]
    else
        lst
        |> List.collect (fun x ->
            permutations (lst |> List.filter ((<>) x)) (n-1)
            |> List.map (fun perm -> x :: perm)
        )

let run n (a: int list) =
    let sorted =
        a
        |> List.sortDescending
        |> List.take 3

    let permutations =
        permutations sorted 3

    permutations
    |> List.map (fun perm ->
        perm
        |> List.map string
        |> String.concat ""
        |> int
    )
    |> List.max

printfn "%i" (run 5 [1; 4; 3; 5; 8])
printfn "%i" (run 8 [813; 921; 481; 282; 120; 900; 555; 409])
