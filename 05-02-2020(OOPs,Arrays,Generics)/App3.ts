function display()
{
    console.log("Hello Bizruntime");
}
display();

function showDetails(id:number, name:string,e_mail_id : string)
{
    console.log("ID:",id,"Name:",name);
    if(e_mail_id != undefined)
    console.log("Email-Id:", e_mail_id);
}
showDetails(32,"Sneha SN");
showDetails(28,"snehasn","sneha@gmail.com");