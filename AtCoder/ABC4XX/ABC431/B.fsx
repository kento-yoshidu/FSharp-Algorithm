// https://atcoder.jp/contests/abc431/tasks/abc431_b

let fn x n (w: int array) q (p: int array) =
    let initialFlag = Array.create n false
    let initialState = (x, initialFlag)

    p
    |> Seq.scan (fun (acc: int , flag: bool array) i ->
        let idx= i - 1

        if flag.[idx] then
            flag.[idx] <- false
            (acc - w.[idx], flag)
        else
            flag.[idx] <- true
            (acc + w.[idx], flag)
        ) initialState
    |> Seq.skip 1
    |> Seq.map fst
    |> Seq.toList

printfn "%A" (fn 31 4 [| 15; 92; 65; 35 |] 4 [| 3; 1; 4; 1 |])
//=> [96; 111; 146; 131]

printfn "%A" (fn 41 10 [| 73; 8; 55; 26; 97; 48; 37; 47; 35; 55 |] 15 [| 1; 2; 7; 1; 6; 3; 10; 8; 4; 8; 1; 5; 9; 9; 3 |])
//=> [114; 122; 159; 86; 134; 189; 244; 291; 317; 270; 343; 440; 475; 440; 385]
