// https://atcoder.jp/contests/abc441/tasks/abc441_b

let check set aSet =
    Set.isSubset set aSet

let fn n m s t q w =
    let sSet = s |> Set.ofSeq
    let tSet = t |> Set.ofSeq

    w
    |> Array.map (fun str ->
        let set = str |> Set.ofSeq

        let takahashi = check set sSet
        let aoki = check set tSet

        if takahashi && aoki then
            "Unknown"
        elif not aoki then
            "Takahashi"
        else
            "Aoki")

printfn "%A" (fn 6 5 "ahikst" "aikot" 5 [| "asahi"; "okita"; "kiai"; "hash"; "it" |])
//=> [| "Takahashi"; "Aoki"; "Unknown"; "Takahashi"; "Unknown" |]

printfn "%A" (fn 7 6 "ahiknst" "ahikos" 5 [| "kioki"; "ohiki"; "tashi"; "nishi"; "kashi" |])
//=> [| "Aoki"; "Aoki"; "Takahashi"; "Takahashi"; "Unknown" |]

printfn "%A" (fn 13 11 "defghiqsvwxyz" "acejmoqrtwx" 15 [| "qhsqzhd"; "jcareec"; "wwqxqew"; "wxqxwex"; "jxxrtwa"; "trtqjxe"; "sqyggse"; "xxqwxew"; "xewwxxw"; "wwqxwex"; "xqqxqwq"; "qxxexxe"; "teqeroc"; "eeeqqee"; "vxdevyy" |])
//=> [| "Takahashi"; "Aoki"; "Unknown"; "Unknown"; "Aoki"; "Aoki"; "Takahashi"; "Unknown"; "Unknown"; "Unknown"; "Unknown"; "Unknown"; "Aoki"; "Unknown"; "Takahashi" |]
