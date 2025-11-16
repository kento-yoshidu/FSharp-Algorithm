// https://atcoder.jp/contests/abc432/tasks/abc432_b

let fn (x: string) =
    let chars = x.ToCharArray()
    System.Array.Sort(chars)

    if chars.[0] = '0' then
        let mutable pos = 1

        while pos < chars.Length && chars.[pos] = '0' do
            pos <- pos + 1

        if pos < chars.Length then
            let tmp = chars.[0]
            chars.[0] <- chars.[pos]
            chars.[pos] <- tmp

    chars |> System.String |> int

printfn "%i" (fn "903")
//=> 309

printfn "%i" (fn "432")
//=> 234

printfn "%i" (fn "100")
//=> 100
