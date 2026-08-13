// https://atcoder.jp/contests/abc359/tasks/abc359_a

let fn _n s =
    s
    |> Array.filter ((=) "Takahashi")
    |> Array.length

printfn "%i" (fn 3 [| "Aoki"; "Takahashi"; "Takahashi" |])
//=> 2

printfn "%i" (fn 2 [| "Aoki"; "Aoki" |])
//=> 0

printfn "%i" (fn 20 [| "Aoki"; "Takahashi"; "Takahashi"; "Aoki"; "Aoki"; "Aoki"; "Aoki"; "Takahashi"; "Aoki"; "Aoki"; "Aoki"; "Takahashi"; "Takahashi"; "Aoki"; "Takahashi"; "Aoki"; "Aoki"; "Aoki"; "Aoki"; "Takahashi" |])
//=> 7
