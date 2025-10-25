import { useEffect, useState } from "react";
import type { Todo } from "./todo";
import { TodoCard } from "./todo-card";

export function TodoPage() {
    const [todoItems, setTodoItems] = useState<Todo[]>([]);

    useEffect(() => {
        const fetchData = async () => {
            const response = await fetch('http://localhost:5088/api/todo')
            if (!response.ok) {
            throw new Error('Failed to fetch products' + response.statusText);
            }
            const todos = await response.json() as Todo[];
            setTodoItems(todos);
        };

        fetchData();
    }, []);

    return (
        <div>
            {todoItems.map((todo) => (
                <TodoCard key={todo.id} todo={todo} />
            ))}
        </div>
    );
}
