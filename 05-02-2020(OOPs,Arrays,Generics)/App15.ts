namespace studentCalc
{
    export function AnualFeeCalc(feeAmount:number, term: number)
    {
        return feeAmount * term;
    }
}

namespace invoiceCalc
{
    export namespace invoiceAccount
    {
        export class Invoice
        {
            public calculateDiscount(price: number)
            {
                return price * 60;
            }
        }
    }
}

let invoice = new invoiceCalc.invoiceAccount.Invoice();

console.log("Output: " +invoice.calculateDiscount(400));