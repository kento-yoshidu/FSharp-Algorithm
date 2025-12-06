// https://atcoder.jp/contests/abc413/tasks/abc413_b

let fn n (s: string[]) =
    [ for i in 0.. n-1 do
        for j in 0 .. n-1 do
            if i <> j then
                yield s.[i] + s.[j] ]
    |> Set.ofList
    |> Set.count

printfn "%i" (fn 4 [| "at"; "atco"; "coder"; "der" |])
//=> 11

printfn "%i" (fn 5 [| "a"; "aa"; "aaa"; "aaaa"; "aaaaa" |])
//=> 7

printfn "%i" (fn 10 [| "armiearggc"; "ukupaunpiy"; "cogzmjmiob"; "rtwbvmtruq"; "qapfzsitbl"; "vhkihnipny"; "ybonzypnsn"; "esxvgoudra"; "usngxmaqpt"; "yfseonwhgp" |])
//=> 90
