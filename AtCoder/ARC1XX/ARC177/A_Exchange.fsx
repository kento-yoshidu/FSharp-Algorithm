// https://atcoder.jp/contests/arc177/tasks/arc177_a

let run (a: int) (b: int) (c: int) (d: int) (e: int) (f: int) (n: int) (x: int list) =
    let vec = [| a; b; c; d; e; f |] // 硬貨の初期状態
    let values = [| 1; 5; 10; 50; 100; 500 |] // 硬貨の価値

    let rec consumeCoins rest index =
        if rest = 0 then
            true
        elif index < 0 then
            false
        else
            let coinValue = values.[index]
            let maxCoins = rest / coinValue
            let usedCoins = min maxCoins vec.[index]
            vec.[index] <- vec.[index] - usedCoins
            consumeCoins (rest - usedCoins * coinValue) (index - 1)

    let rec processPrices prices =
        match prices with
        | [] ->
            "Yes"
        | price :: rest ->
            let success = consumeCoins price (values.Length - 1)
            if success then
                processPrices rest
            else
                "No"

    processPrices x

printfn "%s" (run 0 0 6 3 4 1 3 [700; 250; 160])
//=> Yes

printfn "%s" (run 0 0 0 2 4 0 3 [100; 200; 300])
//=> No

printfn "%s" (run 0 0 0 0 8 8 1 [250])
//=> No

printfn "%s" (run 20 5 9 7 10 6 5 [177; 177; 177; 177; 177])
//=> Yes

printfn "%s" (run 17 5 9 7 10 6 5 [177; 177; 177; 177; 177])
//=> No
