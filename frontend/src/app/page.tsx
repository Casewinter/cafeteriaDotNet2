import Image from "next/image";
import ProductCard from "@/components/composed/productCard";
import test from "../lib/test"



const categories = Object.entries(test)

export default function Home() {
  return (
    <div className="flex flex-col items-center justify-items-center min-h-screen  p-20 gap-16 sm:p-20 font-[family-name:var(--font-geist-sans)]">
      <main className="flex gap-4">
        {
          categories.map(([_, products]) =>
            products.map(p => <ProductCard key={p.id} {...p} />)
          )
        }
      </main>
      <footer className="row-start-3 flex gap-6 flex-wrap items-center justify-center">

      </footer>
    </div>
  );
}
