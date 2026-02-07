// https://atcoder.jp/contests/abc390/tasks/abc390_a

let fn (a: int array) =
    let A = [| 1; 2; 3; 4; 5|]

    let isOk =
        [0..3]
        |> List.exists (fun i ->
            let B = Array.copy a

            let tmp = B.[i]
            B.[i] <- B.[i+1]
            B.[i+1] <- tmp

            B = A)

    if isOk then "Yes" else "No"

printfn "%s" (fn [| 1; 2; 4; 3; 5|])
//=> Yes

printfn "%s" (fn [| 5; 3; 2; 4; 1|])
//=> No

printfn "%s" (fn [| 1; 2; 3; 4; 5|])
//=> No

printfn "%s" (fn [| 2; 1; 3; 4; 5|])
//=> Yes
