import type { Route } from "./+types/home";
import { TodoPage } from "~/todo/todo-page";

// eslint-disable-next-line no-empty-pattern
export function meta({}: Route.MetaArgs) {
  return [
    { title: "Todo Kazoo" },
    { name: "description", content: "Welcome to Todo Kazoo!" },
  ];
}

export default function Home() {
  return <TodoPage />;
}
