// https://atcoder.jp/contests/abc381/tasks/abc381_c

let run (n: int) (s: string) : int =
    let rec countMatching dis i =
        if dis < i && i + dis < n then
            if s.[i - dis - 1] = '1' && s.[i + dis + 1] = '2' then
                countMatching (dis + 1) i
            else
                dis
        else
            dis

    let calculateMax i =
        if s.[i] = '/' then
            countMatching 0 i
        else
            0

    [0 .. n - 1]
    |> List.map calculateMax
    |> List.max
    |> fun maxdis -> maxdis * 2 + 1

printfn "%i" (run 8 "211/2212")
//=> 5

printfn "%i" (run 5 "22/11")
//=> 1

printfn "%i" (run 22 "/1211/2///2111/2222/11")
//=> 7
