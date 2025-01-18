import { Card, CardHeader, CardContent, CardFooter } from "@/components/ui/card"

type productCard = {
    id: string
    name: string,
    description: string
    photo: string,
    weight: number
}
export default function ProductCard(
    product: productCard
) {
    return (
        <Card>
            <CardHeader>
                <h2>{product.name}</h2>
            </CardHeader>
            <CardContent>
                <div
                    className="flex gap-2"
                ><div>
                        <div className="w-20 h-30 overflow-hidden rounded-md"> {/* Contêiner com largura total e altura fixa */}
                            <img
                                src={product.photo == "" ? "https://images.unsplash.com/photo-1729291301216-a96588457289?q=80&w=987&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D" : product.photo} alt="Produto"
                            />
                        </div>
                    </div>
                    <div
                        className="w-[300px]">
                        <p>{product.description}</p>
                    </div>
                </div>
            </CardContent>
            <CardFooter>
                <button className="btn btn-primary">Adicionar ao Carrinho</button>
            </CardFooter>
        </Card>
    );
}


