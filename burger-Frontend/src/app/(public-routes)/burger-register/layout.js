import { getServerSession } from "next-auth"
import { handler } from "@/app/api/auth/[...nextauth]/route"
import { redirect } from "next/navigation"


export const metadata = {
    title: 'Burger - Cadastro',
  }

export default async function PrivateLayout({children}){ 

    const session = await getServerSession(handler)

  
    if(session){
        redirect('/burger-order')
    }

    return(
        <>{children}</>
    )
}